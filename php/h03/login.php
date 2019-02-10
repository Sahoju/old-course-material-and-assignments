<?php
    session_start();

    $usernames = array('admin', 'Jeanne', 'Solar');
    $passwords = array('admin', 'dArc', 'Fields');
    $errmsg = '';

    if(isset($_POST['username']) AND isset($_POST['passwd'])) {
        for($i = 0; $i < count($usernames); $i++) {
            if($_POST['username'] === $usernames[$i] AND $_POST['passwd'] === $passwords[$i]) {
                $_SESSION['isLogged'] = true;
                $_SESSION['username'] = $_POST['username'];
                header("Location: http://"
                       . $_SERVER['HTTP_HOST']
                       . dirname($_SERVER['PHP_SELF'])
                       . '/h03t03.php');
                exit;
            } else {
                $errmsg = "<p style='color:red;'>Tunnus/Salasana väärin!</p>";
            }
        }
    }
?>

<!DOCTYPE html>
<html>
    <head>
        <title>Tehtävä 3 login</title>
        <meta charset="utf-8" />
        <link rel="stylesheet" type="text/css" href="style_logout.css" />
    </head>
    
    <body>
        <div id="box">
            <form method="post" action="<?php echo $_SERVER['PHP_SELF']; ?>">
                Käyttäjätunnus:<br/>
                <input type="text" name="username"><br/><br/>
                Salasana:<br/>
                <input type="password" name="passwd"><br/><br/>
                <input type="submit" value="Kirjaudu">
            </form>
            <?php
                if($errmsg != '') { echo $errmsg; }
            ?>
        </div>
    </body>
</html>