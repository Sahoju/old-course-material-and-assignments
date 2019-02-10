<!DOCTYPE html>
<html>
	<head>
		<title>Harjoitus 2, tehtävä 4</title>
		<meta charset="utf-8">
	</head>
	
	<body>
		<form method='post' action='h02t04.php'>
			<input type='submit' name='butan' value='Next'>
			<input type='text' name='part'>
		</form>
		
		<?php
			session_start();
			$blurb = '';
			if(!isset($_POST['part'])) {
				$part = '';
			} else {
				$part = $_POST['part'];
			}
		
			if(!isset($_SESSION['counter'])) {
				$_SESSION['counter'] = 1;
				$blurb = file_get_contents('00.txt');
			}
			else if($_SESSION['counter'] == 24 || $part == '0') {
				$_SESSION['counter'] = 0;
			}
			else if ($_SESSION['counter'] < 10) {
				$blurb = file_get_contents('0' . $_SESSION['counter'] . '.txt');
				// $count = $_SESSION['counter'] + 1;
				$_SESSION['counter']++;
			}
			else if ($_SESSION['counter'] >= 10) {
				$blurb = file_get_contents($_SESSION['counter'] . '.txt');
				$_SESSION['counter']++;
			}
			
			echo $blurb;
			// echo "<br/><br/>" . $_SESSION['counter'];
		?>
		
	</body>
</html>