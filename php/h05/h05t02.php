<!DOCTYPE html>
<html>
    <head>
        <title>Harjoitus 5, tehtävä 2</title>
        <meta charset="utf-8" />
    </head>
    
    <body>
        <form method='post' action='h05t02.php'>
            <input type="text" name="input"><br/>
            <input type="submit" name="submit">
        </form>
        
        <?php
            $check = '/^[0-9]{5}(-[0-9]{4})?$/';
        
            if(isset($_POST['input'])) {
                if(preg_match($check, $_POST['input'])) {
                    echo 'yay';
                } else {
                    echo 'nay';
                }
            }
        ?>
    </body>
</html>