<!DOCTYPE html>
<html>
    <head>
        <title>Harjoitus 5, tehtävä 3</title>
        <meta charset="utf-8" />
    </head>
    
    <body>
        <form method='post' action='h05t03.php'>
            <input type="text" name="input"><br/>
            <input type="submit" name="submit">
        </form>
        
        <?php
            $check = '/^(0|\+358)\ ?40\ ?[0-9]{3}\ ?[0-9]{3}\ ?[0-9]$/';
        
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