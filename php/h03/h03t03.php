<?php
    session_start();
    //include('login.php');

    if(!isset($_SESSION['isLogged']) || $_SESSION['isLogged'] !== true) {
        header('Location: http://'
               . $_SERVER['HTTP_HOST']
               . dirname($_SERVER['PHP_SELF'])
               . '/login.php');
        exit;
    }

    if(!isset($_SESSION['saldo'])) { $_SESSION['saldo'] = 500; }
    if(!isset($_SESSION['panos'])) { $_SESSION['panos'] = 100; }
?>

<!DOCTYPE html>
<html>
    <head>
        <title>Harjoitus 3, tehtävä 3</title>
        <link rel="stylesheet" type="text/css" href="style_main.css" />
    </head>

    <body>
        <?php
            $nappi = $_POST['change'];
        
            // muokataan saldoa ja panosta riippuen, mitä painiketta painettiin
            switch($nappi) {
                case 'Aseta panos':
                    $_SESSION['panos'] = $_POST['panos'];
                    break;
                case 'Siirrä rahaa':
                    $_SESSION['saldo'] += $_POST['saldo'];
                    break;
                case 'Nollaa tili':
                    $_SESSION['saldo'] = 500;
                    break;
            }
        
            // katsotaan, voittaako pelaaja mitään
            $oneWinner = 4;
            $twoWinner = 4;
            $ones = array(rand(0,3), rand(0,3), rand(0,3));
            $twos = array(rand(1,3), rand(1,3), rand(1,3));
        
            for($i = 0; $i < 3; $i++) {
                if($oneWinner == 4 AND $twoWinner == 4) {
                    $oneWinner = $ones[$i];
                    $twoWinner = $twos[$i];
                }
                
                if($oneWinner != $ones[$i]) {
                    $oneWinner = 5;
                }
                
                if($twoWinner != $twos[$i]) {
                    $twoWinner = 5;
                }
            }
        
            $_SESSION['saldo'] -= $_SESSION['panos'];
            $winnerText = '';
        
            if ($oneWinner >= 1 AND $oneWinner <= 3 AND $twoWinner >= 1 AND $twoWinner <= 3) {
                $winnerText = "<p>Voitit " . $_SESSION['panos'] * 100 . " eur! Ari sanoo VAU!</p>";
                $_SESSION['saldo'] += $_SESSION['panos'] * 100;
            }
            else if ($oneWinner >= 0 AND $oneWinner <= 3) {
                $winnerText = "<p>Voitit " . $_SESSION['panos'] * 10 . " eur!</p>";
                $_SESSION['saldo'] += $_SESSION['panos'] * 10;
            }
            else if ($twoWinner >= 1 AND $twoWinner <= 3) {
                $winnerText = "<p>Voitit " . $_SESSION['panos'] * 10 . " eur!</p>";
                $_SESSION['saldo'] += $_SESSION['panos'] * 10;
            }
            else {
                $winnerText = "<p>Et voittanut mitään.</p>";
            }
        
            $content = <<<EOD
                <form method="post" action="{$_SERVER['PHP_SELF']}">
                    <div id="control">
                        <div class="inline">
                            Käyttäjä: {$_SESSION['username']}<br/>
                            <a href="logout.php">Kirjaudu ulos</a>
                        </div>
                        <div class="inline">
                            <input type="text" name="saldo"><br/>
                            <input type="submit" name="change" value="Siirrä rahaa">
                        </div>
                        <div class="inline">
                            <input type="text" name="panos"><br/>
                            <input type="submit" name="change" value="Aseta panos">
                        </div>
                        <div class="inline">
                            <input type="submit" name="change" value="Nollaa tili">
                        </div>
                    </div>
                    <br/><br/><br/><br/>
                    <hr>
                    <div id="playground">
                        <div class="pgInline">
                            Saldo:<br/>
                            {$_SESSION['saldo']} eur
                        </div>
                        <div class="pgInline">
                            Panos:<br/>
                            {$_SESSION['panos']} eur
                        </div>
                        <div id="play">
                            <input type="submit" name="change" value="Rullaa!">
                        </div>
EOD;
        
            echo $content;
        
            for($i = 0; $i < 3; $i++) {
                echo '<img src="/~L4929/ttms0900/h01/img/' . $ones[$i] . $twos[$i] . '.png" /> ';
            }
        
            echo $winnerText;
            echo "</div></form>";
        
            
        ?>
    </body>
</html>