<?php
    require_once('/home/L4929/php-dbconfig/db-init.php');

    $stmt = lisaaHenkilo($db);

    function lisaaHenkilo($db) {
        $id = (isset($_POST['tunnus'])) ? $_POST['tunnus'] : '';
        $sname = (isset($_POST['sukunimi'])) ? $_POST['sukunimi'] : '';
        $fname = (isset($_POST['etunimi'])) ? $_POST['etunimi'] : '';
        $addr = (isset($_POST['osoite'])) ? $_POST['osoite'] : '';
        $phone = (isset($_POST['puhnro'])) ? $_POST['puhnro'] : '';
        $email = (isset($_POST['email'])) ? $_POST['email'] : '';

        $sql = "insert into henkilot (
            tunnus,
            sukunimi,
            etunimi,
            osoite,
            puhnro,
            email
            ) values (
            :id,
            :sname,
            :fname,
            :addr,
            :phone,
            :email
            )";
        
        $stmt = $db->prepare($sql);
        $stmt->bindValue(':id', "$id", PDO::PARAM_STR);
        $stmt->bindValue(':sname', "$sname", PDO::PARAM_STR);
        $stmt->bindValue(':fname', "$fname", PDO::PARAM_STR);
        $stmt->bindValue(':addr', "$addr", PDO::PARAM_STR);
        $stmt->bindValue(':phone', "$phone", PDO::PARAM_STR);
        $stmt->bindValue(':email', "$email", PDO::PARAM_STR);
        $stmt->execute();
        return $stmt;
    }

    $rows = $stmt->rowCount();
    if($rows == 1) { echo "Uusi tietue lisättiin ainakin melkein!"; }
?>
