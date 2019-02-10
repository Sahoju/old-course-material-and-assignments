<?php
    session_start();
    if(isset($_SESSION['isLogged'])) {
        unset($_SESSION['isLogged']);
        $_SESSION['panos'] = 100;
        $_SESSION['saldo'] = 500;
    }

    header("Location: http://"
          . $_SERVER['HTTP_HOST']
          . dirname($_SERVER['PHP_SELF'])
          . '/login.php');
?>