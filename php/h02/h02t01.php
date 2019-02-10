<!DOCTYPE html>
<html>
	<head>
		<title>Harjoitus 2, tehtävä 1</title>
		<meta charset="utf-8" />
	</head>

	<body>
		Mikä on?<br/>
		
		<?php
			$isHappy = '';
			$isFriday = '';
			$isOkay = '';
			
			$stuff = <<<EOD
				<form method="post" action="{$_SERVER['PHP_SELF']}">
					<input type="checkbox" name="happy" $isHappy> Pirteä<br/>
					<input type="checkbox" name="friday" $isFriday> Perjantai<br/>
					<input type="checkbox" name="okay" $isOkay> Ok<br/>
					<input type="submit" name="butan"><br/><br/>
				</form>
EOD;
			
			echo $stuff;
			
			if (isset($_POST['happy'])) {
				echo "On kivaa! ";
				$isHappy = 'checked';
			}
			
			if (isset($_POST['friday'])) {
				echo "On perjantai! ";
				$isFriday = 'checked';
			}
			
			if (isset($_POST['okay'])) {
				echo "Kaikki on hyvin! ";
				$isOkay = 'checked';
			}
		?>
	</body>

</html>