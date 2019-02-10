<title>Harjoitus 1, tehtävä 1</title>
<?php
$weight = $_POST['weight'] - 5;
echo "Mikä on painosi kiloina: <strong>" . $_POST['weight'] . "</strong><br>";
echo "Minun painoni on <strong> " . $weight . "</strong>, sinulla taitaa olla paino-ongelmia?<p>";
?>