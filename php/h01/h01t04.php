<title>Harjoitus 1, tehtävä 4</title>

<?php
    for($i = 0; $i < 3; $i++) {
        $one = rand(0,3);
        $two = rand(1,3);
        echo '<img src="/~L4929/ttms0900/h01/img/' . $one . $two . '.png" /> ';
    }
?>