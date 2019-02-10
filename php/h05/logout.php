<?php
session_start();
 
if (isset($_SESSION['isLogged'])) {
    unset($_SESSION['isLogged']);
}
if (isset($_SESSION['uid'])) {
    $_SESSION['uid'] = '';
}
 
header("Location: http://" . $_SERVER['HTTP_HOST']
                           . dirname($_SERVER['PHP_SELF']) . '/'
                           . "h05t04.php");
?>