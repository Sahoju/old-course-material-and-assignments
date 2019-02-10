<?php
    session_start();
    require_once ("/home/L4929/php-dbconfig/db-init.php");

    echo "Käyttäjä: ";
    if(isset($_SESSION['isLogged'])) {
        echo $_SESSION['uid'] . "<br/>";
        echo "<a href='logout.php'>Kirjaudu ulos</a><br/>";
    } else {
        echo "guest<br/>";
        echo "<a href='login.php'>Kirjaudu sisään</a><br/>";
    }

    $stuff = <<<EOD
        <style type='text/css'>
            tr:nth-child(odd) {background: #f1f1f1}
            tr:nth-child(even) {background: #ffffff}
            tr:nth-child(1) {background: #ffeedd}
        </style>
EOD;

    if($_SESSION['uid'] == 'admin') {
        $stuff .= "<a href='addform.php'>Lisää tietue</a>";
    }

    $stuff .= <<<EOD
        <form method="post" action="h05t04.php">
            <input type="text" name="searchInput" placeholder="Hae sukunimellä">
            <input type="submit" name="searchSubmit" value="Hae!">
        </form>
        <hr>
EOD;

    $hakuehto = isset($_POST['searchInput']) ? $_POST['searchInput'] : '';

    $stmt = haeHenkilot($db, $hakuehto);
    $stuff .= sqlResult2Html($stmt);

    echo $stuff;

    function haeHenkilot($db, $hakuehto) {
       $sql = <<<SQLEND
           SELECT tunnus, sukunimi, etunimi, email, osoite, puhnro
           FROM henkilotpwds WHERE sukunimi
           LIKE :hakuehto
SQLEND;

       $stmt = $db->prepare($sql);
       $stmt->bindValue(':hakuehto', "%$hakuehto%", PDO::PARAM_STR);
       $stmt->execute();
       return $stmt;    
    }

    // SQL-kyselyn tulosjoukko HTML-taulukkoon.
    function sqlResult2Html($stmt) {
        $row_count = $stmt->rowCount();
        $col_count  = $stmt->columnCount();

        $stuff = "Hakutulokset: " . $row_count. " riviä<hr>\n";
        $stuff .= "<table border='0'>\n";
        $stuff .= <<<OUTPUTEND
            <tr bgcolor='#ffeedd'>
                <td>Tunnus</td><td>Sukunimi</td><td>Etunimi</td>
                <td>Osoite</td><td>Puhnro</td><td>Email</td>
            </tr>
OUTPUTEND;

        while($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
            $stuff .= '<tr><td>';
            
            if($_SESSION['uid'] == $row['tunnus'] || $_SESSION['uid'] == 'admin') {
                $stuff .= "<a href='editform.php?id={$row['tunnus']}'>{$row['tunnus']}</a>";
            } else {
                $stuff .= $row['tunnus'];
            }
            
            $stuff .= <<<EOD
                    </td>
                    <td>{$row['sukunimi']}</td><td>{$row['etunimi']}</td>
                    <td>{$row['osoite']}</td><td>{$row['puhnro']}</td><td>{$row['email']}</td>
                </tr>
EOD;
        }
        $stuff .= "</table>\n";
        return $stuff;
    }
?>