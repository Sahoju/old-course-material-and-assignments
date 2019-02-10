<?php
 
if (!isset($_SESSION['app2_islogged']) || $_SESSION['app2_islogged'] !== true) {
   echo "[Kirjautunut: --] ";
   echo "[ <a href='login.php'>Kirjaudu</a> ]";
} else {
   echo "[Kirjautunut: <span style='background: yellow;'>{$_SESSION['uid']}</span> ] ";
   echo "[<a href='logout.php'>Kirjaudu ulos</a>]";
}
 
?>