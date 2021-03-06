<?php
    // poista.php

    require_once ("/home/L4929/php-dbconfig/db-init.php");

    $tunnus = isset($_POST['tunnus']) ? $_POST['tunnus'] : '';

    $stmt = poistaHenkilo($db, $tunnus);

    // 
    function poistaHenkilo($db, $tunnus) {
       $sql = <<<SQLEND
       DELETE
       FROM henkilotpwds WHERE tunnus = :tunnus
SQLEND;

       $stmt = $db->prepare($sql);
       $stmt->bindValue(':tunnus', "$tunnus", PDO::PARAM_STR);
       $stmt->execute();
       return $stmt;    
    }

    $rows = $stmt->rowCount(); 
    if ($rows == 1) { echo "$tunnus todellakin poistettiin!"; }
?>