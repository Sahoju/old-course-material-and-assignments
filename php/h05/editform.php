<?php
    session_start();
    require_once ("/home/L4929/php-dbconfig/db-init.php");

    echo 'Käyttäjä: ' . $_SESSION['uid'];

    $tunnus = isset($_GET['id']) ? $_GET['id'] : '';

    $stmt = haeHenkilo($db, $tunnus);
    teelomake($stmt);

    // 
    function haeHenkilo($db, $tunnus) {
       $sql = <<<SQLEND
       SELECT tunnus, sukunimi, etunimi, email, osoite, puhnro
       FROM henkilotpwds WHERE tunnus = :tunnus
SQLEND;

       $stmt = $db->prepare($sql);
       $stmt->bindValue(':tunnus', "$tunnus", PDO::PARAM_STR);
       $stmt->execute();
       return $stmt;    
    }

    // SQL-kyselyn tulosjoukko HTML-taulukkoon.
    function teelomake($stmt) {
        $row = $stmt->fetch(PDO::FETCH_ASSOC);

        $forms = <<<EOLomake
            <title>Osoitekirja</title> 
            <style type="text/css">
            h2 { border-top: solid thin black;
            color:#000;background-color:#fed }
            </style>
            <form method='post' action='h04t01.php'>
                <a href='h05t04.php'>Näytä kaikki osoitteet</a>
                 | <a href='addform.php'>Lisää osoite</a>
                 | <input type='text' size='10' name='sukunimi' value=''>
                <input type='submit' value='Hae!'>
            </form>
            <h2>Osoitekirja</h2>
            <em>Muokkaa osoitetta</em>
            <form method='post' action='muokkaa.php'>
                <table border='0' cellpadding='5'>
                    <tr valign='top'>
                        <td align='right' bgcolor='#ffeedd'>Tunnus</td>
                        <td bgcolor='#dddddd'>{$row['tunnus']}<input type='hidden' name='tunnus' value='{$row['tunnus']}'></td>
                    </tr>
                    <tr valign='top'>
                        <td align='right' bgcolor='#ffeedd'>Sukunimi</td>
                        <td bgcolor='#dddddd'><input type='text' name='sukunimi' size='30' value='{$row['sukunimi']}' required></td>
                    </tr>
                    <tr valign='top'>
                        <td align='right' bgcolor='#ffeedd'>Etunimi</td>
                        <td bgcolor='#dddddd'><input type='text' name='etunimi' size='30' value='{$row['etunimi']}' required></td>
                    </tr>
                    <tr valign='top'>
                        <td align='right' bgcolor='#ffeedd'>Osoite</td>
                        <td bgcolor='#dddddd'><input type='text' name='osoite' size='30' value='{$row['osoite']}' required></td>
                    </tr>
                    <tr valign='top'>
                        <td align='right' bgcolor='#ffeedd'>Puhnro</td>
                        <td bgcolor='#dddddd'><input type='text' name='puhnro' size='30' value='{$row['puhnro']}' required></td>
                    </tr>
                    <tr valign='top'>
                        <td align='right' bgcolor='#ffeedd'>Email</td>
                        <td bgcolor='#dddddd'><input type='text' name='email' size='30' value='{$row['email']}' required></td>
                    </tr>
                </table>
                <input type='submit' name='action' value='Tallenna muutokset' onclick="javascript: return confirm('Hyväksy muutokset?')">
            </form>

            <form method='post' action='poista.php'>
                <input type='hidden' name='tunnus' value='{$row['tunnus']}'>
                <input type='submit' name='action' value='Poista' onclick="javascript: return confirm('Hyväksy poisto?')">
            </form>
EOLomake;

        echo $forms;
    }
?>