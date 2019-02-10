<!DOCTYPE html>
<html>
    <head>
        <title>Harjoitus 3, tehtävä 2</title>
        <meta charset="utf-8" />
    </head>

    <body>
        <h3 style=background-color:#fed;color:#000>Autolaskuri</h3>
        <?php
            // Pääohjelma
        
            session_start();

            // getting current counts from session variables
            if (!isset($_SESSION['vw'])) { $_SESSION['vw'] = 0; }
            if (!isset($_SESSION['opel'])) { $_SESSION['opel'] = 0; }
        
            $painike = '';
            if (isset($_POST['painike'])) { $painike = $_POST['painike']; }
        
            laske_lkm($painike);
            tee_lomake();
            nayta_tulokset();

            // Alustetaan tai päivitetään autojen lukumääriä:
            // Muodolliset parametrit ovat viittauksia, joten
            // muutetut arvot välittyvät "takaisin" kutsuvaan
            // ohjelmalohkooon
            function laske_lkm($nappi) {
               // Jotakin autonappia painettu, lisätään kertymää
               if ($nappi == "VW") {
                  $_SESSION['vw'] += 1;
               }
               elseif ($nappi == "Opel") {
                  $_SESSION['opel'] += 1;
               }
               // Painettiin Nollaa-painiketta
               elseif ($nappi == "Nollaa") {
                  $_SESSION['vw'] = 0;
                  $_SESSION['opel'] = 0;
               }
            }

            function nayta_tulokset() {
               echo "<pre>\n";
               echo "Volkswagenit ... : " . $_SESSION['vw'] . " kpl.\n";
               echo "Opelit ......... : " . $_SESSION['opel'] . " kpl.\n";
               echo "</pre>\n";
            }

            // Tehdään lomake piilokenttineen
            function tee_lomake() {
                $lomake = <<<EOD
                    <form method="post" action="{$_SERVER['PHP_SELF']}">
                        <input type="submit" value="VW" name="painike">
                        <input type="submit" value="Opel" name="painike">
                        <input type="submit" value="Nollaa" name="painike">
                    </form>
EOD;
                echo $lomake;
            }

        ?>
    </body>
</html>