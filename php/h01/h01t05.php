<title>Harjoitus 1, tehtävä 5</title>

<form method="post"
      action="h01t05.php">
    Anna rivien määrä:<br><input type="text" name="amount"><br>
    <input type="submit" name="butan" value="Lähetä">
</form>

<?php
    if(!isset($_POST['butan'])) exit();
    $num = $_POST['amount'];

    echo '<table>';
    for ($i = 1; $i <= $num; $i++) {
        if($i % 2 == 0) {
            echo '<tr><td style="background-color:#fff">' . $i . '. rivi</td></tr>';
        } else {
            echo '<tr><td style="background-color:#ff0">' . $i . '. rivi</td></tr>';
        }
    }
    echo '</table>';
?>