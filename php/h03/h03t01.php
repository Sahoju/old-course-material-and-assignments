<!DOCTYPE html>
<html>
    <head>
        <title>Harjoitus 3, tehtävä 1</title>
        <meta charset="utf-8" />
    </head>

    <body>
        <h3 style=background-color:#fed;color:#000>Autolaskuri</h3>
        <?php
            // autolaskuri-v1.php

            // Pääohjelma

            // getting current counts from cookies
            if (isset($_COOKIE['vw'])) { $vw_lkm = $_COOKIE['vw']; }
            else { $vw_lkm = 0; }
            if (isset($_COOKIE['opel'])) { $opel_lkm = $_COOKIE['opel']; }
            else { $opel_lkm = 0; }
        
            $painike = '';
            if (isset($_POST['painike'])) { $painike = $_POST['painike']; }

            laske_lkm($vw_lkm, $opel_lkm, $painike);
            tee_lomake();
            nayta_tulokset($vw_lkm, $opel_lkm);
        
            setcookie('vw', $vw_lkm, time()+86400);
            setcookie('opel', $opel_lkm, time()+86400);

            // Alustetaan tai päivitetään autojen lukumääriä:
            // Muodolliset parametrit ovat viittauksia, joten
            // muutetut arvot välittyvät "takaisin" kutsuvaan
            // ohjelmalohkooon
            function laske_lkm(&$vw_lkm, &$opel_lkm, $nappi) {
               // Jotakin autonappia painettu, lisätään kertymää
               if ($nappi == "VW") {
                  $vw_lkm += 1;
               }
               elseif ($nappi == "Opel") {
                  $opel_lkm += 1;
               }
               // Painettiin Nollaa-painiketta
               elseif ($nappi == "Nollaa") {
                  $vw_lkm = 0;
                  $opel_lkm = 0;
               }
            }

            function nayta_tulokset($vw_lkm, $opel_lkm) {
               echo "<pre>\n";
               echo "Volkswagenit ... : $vw_lkm kpl.\n";
               echo "Opelit ......... : $opel_lkm kpl.\n";
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