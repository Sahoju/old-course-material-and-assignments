<!DOCTYPE html>
<?php
    if(isset($_GET['searchEngine']) AND isset($_GET['searchInput'])) { 
        $search = 'Location: ';
        $search .= $_GET['searchEngine'] . '/search?q=';
        $search .= urlencode($_GET['searchInput']);
        header($search);
    }
?>
<html>
    <head>
        <title>Harjoitus 5, tehtävä 1</title>
    </head>
    
    <body>
        <h1>Metahakupalvelu</h1>
        
        <?php
            $stuff = <<<EOD
<form method="get" action="{$_SERVER['PHP_SELF']}">
    <input type="text" name="searchInput"> <input type="submit"><br/>
    <select name="searchEngine">
        <option value="https://www.google.com">Google</option>
        <option value="https://www.bing.com">Bing</option>
        <option value="https://www.yahoo.com">Yahoo</option>
    </select>
</form>
EOD;
            echo $stuff;
        ?>
        
    </body>
</html>