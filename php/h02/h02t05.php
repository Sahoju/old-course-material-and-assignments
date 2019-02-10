<!DOCTYPE html>
<html>
	<head>
		<title>Harjoitus 2, tehtävä 5</title>
	</head>

	<body>
		<h2>Haluatko köyhäksi?</h2>
		<form method='post' action='h02t05.php'>
			<p>1. Hauki on mikä?</p>
			<input name='one' type='radio' value='1'> kala<br/>
			<input name='one' type='radio' value='0'> lintu<br/>
			<input name='one' type='radio' value='0'> kissa<br/>
			
			<p>2. Mitä kirjainlyhenne PHP tarkoittaa puhuttaessa Web-ohjelmoinnista?</p>
			<select name='two'>
				<option value='-2'>Peaceful Human Programming</option>
				<option value='2'>PHP: Hypertext Preprocessing</option>
				<option value='-2'>Professional Hypertext Parser</option>
			</select><br/>
			
			<p>3. Mikä tai mitkä kirjaimet vastaavat miljoonaa?</p>
			<input type='checkbox' name='three[]' value='-3'> m<br/>
			<input type='checkbox' name='three[]' value='3'> M<br/>
			<input type='checkbox' name='three[]' value='-3'> µ<br/>
			
			<p>4. Moshi moshi,</p>
			<input type='checkbox' name='four[]' value='3'> Jesus desu<br/>
			<input type='checkbox' name='four[]' value='3'> It's me! Me!<br/>
			<input type='checkbox' name='four[]' value='3'> Mochi<br/><br/>
			
			<input type='submit' name='butan'>
		</form><br/>
		
		<?php
			if(!isset($_POST['butan'])) exit();
		
			$result = $_POST['one'];
			$result += $_POST['two'];
			
			if(isset($_POST['three'])) {
				foreach($_POST['three'] as $choice) {
					$result += $choice;
				}
			} else {
				$result -= 3;
			}
			
			if(isset($_POST['four'])) {
				foreach($_POST['four'] as $choice) {
					$result += $choice;
				}
			} else {
				$result -= 3;
			}
			
			if($result > 0) {
				echo "Onneksi olkoon, voitit $result köyhäpistettä!<br/>";
			} else {
				echo "Et voittanut ainuttakaan köyhäpistettä. Se onkin ainoa tapa voittaa tämä peli! Onneksi olkoon!<br/>";
			}
		?>
		
    </body>
</html>