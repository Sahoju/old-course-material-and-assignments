<?php
    require_once('/home/L4929/php-dbconfig/db-init.php');
    require_once 'PasswordLib.phar';
    $lib = new PasswordLib\PasswordLib();

    $stmt = lisaaHenkilo($db);

    function lisaaHenkilo($db) {
        $lib = new PasswordLib\PasswordLib();
        
        $id = (isset($_POST['tunnus'])) ? $_POST['tunnus'] : '';
        $sname = (isset($_POST['sukunimi'])) ? $_POST['sukunimi'] : '';
        $fname = (isset($_POST['etunimi'])) ? $_POST['etunimi'] : '';
        $addr = (isset($_POST['osoite'])) ? $_POST['osoite'] : '';
        $phone = (isset($_POST['puhnro'])) ? $_POST['puhnro'] : '';
        $email = (isset($_POST['email'])) ? $_POST['email'] : '';
        $auth = (isset($_POST['auth'])) ? $_POST['auth'] : '';
        $passwd = (isset($_POST['passwd'])) ? $lib->createPasswordHash($_POST['passwd'],  '$2a$', array('cost' => 12)) : '';

        $sql = "insert into henkilotpwds (
tunnus,
sukunimi,
etunimi,
osoite,
puhnro,
email,
password,
auth
) values (
:id,
:sname,
:fname,
:addr,
:phone,
:email,
:passwd,
:auth
)";
        
        $stmt = $db->prepare($sql);
        $stmt->bindValue(':id', "$id", PDO::PARAM_STR);
        $stmt->bindValue(':sname', "$sname", PDO::PARAM_STR);
        $stmt->bindValue(':fname', "$fname", PDO::PARAM_STR);
        $stmt->bindValue(':addr', "$addr", PDO::PARAM_STR);
        $stmt->bindValue(':phone', "$phone", PDO::PARAM_STR);
        $stmt->bindValue(':email', "$email", PDO::PARAM_STR);
        $stmt->bindValue(':passwd', "$passwd", PDO::PARAM_STR);
        $stmt->bindValue(':auth', "$auth", PDO::PARAM_STR);
        $stmt->execute();
        return $stmt;
    }

    $rows = $stmt->rowCount();
    if($rows == 1) { echo "Uusi tietue lisättiin ainakin melkein!"; }
?>
