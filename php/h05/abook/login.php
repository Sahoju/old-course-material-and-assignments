<?php
session_start();
require_once '../PasswordLib.phar';
$lib = new PasswordLib\PasswordLib();
  
$errmsg = '';
if (isset($_POST['uid']) AND isset($_POST['passwd'])) {
require_once('/home/L4929/php-dbconfig/db-init.php');
  
  
  
   $uid = $_POST['uid'];
   $passwd = $_POST['passwd'];
  
   $sql = "SELECT tunnus, password
            FROM henkilotpwds
            WHERE tunnus = :uid";
      
    $stmt = $db->prepare($sql);
    $stmt->execute(array($uid));
    $row = $stmt->fetch(PDO::FETCH_ASSOC);  
  
    if ($stmt->rowCount() == 1 AND $lib->verifyPasswordHash($passwd, $row['password'])) {
  
        $_SESSION['app2_islogged'] = true;
        $_SESSION['uid'] = $_POST['uid'];
         header("Location: http://" . $_SERVER['HTTP_HOST']
                                    . dirname($_SERVER['PHP_SELF']) . '/'
                                    . "main-secure.php");
        exit;
    } else {
        $errmsg = '<span style="background: yellow;">Tunnus/Salasana vaarin!</span>';
    }
}
?>
  
<title>Kirjautusmislomake</title>
  
<?php
if ($errmsg != '')echo $errmsg;
?>
 
 
<p>Tunnus/salasanaparit: admin/sala, ara/sala ja ara2/sala</p>
<form method="post" action="<?php echo $_SERVER['PHP_SELF'];?>"
style=color:#000;background-color:#eeeeee>
Tunnus:<br><input type="text" name="uid" size="30"><br>
Salasana:<br><input type="text" name="passwd" size="30"><br>
<input type='submit' name='action' value='Kirjaudu'>
<br>
</form>