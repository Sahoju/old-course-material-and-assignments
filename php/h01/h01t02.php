<title>Harjoitus 1, tehtävä 2</title>

<form method="get"
      action="h01t02.php">
Anna euromäärä:<br><input type="text" name="amount"><br>
<input type="submit" name="butan" value="Lähetä">
</form>

<?php
    if(!isset($_GET['butan'])) exit();
    $markat = $_GET['amount'] * 6;
    echo $_GET['amount'] . " euroa on " . $markat . " markkaa.";
?>