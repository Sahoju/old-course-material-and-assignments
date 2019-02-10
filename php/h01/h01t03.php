<title>Harjoitus 1, tehtävä 3</title>

<form method="post"
      action="h01t03.php">
    Anna tähtien määrä:<br><input type="text" name="amount"><br>
    <input type="submit" name="butan" value="Lähetä">
</form>

<?php
    if(!isset($_POST['butan'])) exit();
    $num = $_POST['amount'];
    for ($i = 0; $i < $num; $i++) {
        echo "*";
    }
?>