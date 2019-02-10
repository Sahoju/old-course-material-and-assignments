<!DOCTYPE html>

<html>
	<head>
		<title>Harjoitus 2, tehtävä 2</title>
	</head>
	
	<body>
		<?php
			// add keys and values to table
			$bgColors["Punainen"] = "#e25c4d";
			$bgColors["Vihreä"] = "#44c944";
			$bgColors["Sininen"] = "#434cc6";
			$bgColors["Syaani"] = "#42c4b5";
			$txtColors["Magenta"] = "#c141b9";
			$txtColors["Keltainen"] = "#b8bf41";
			$txtColors["Valkoinen"] = "#fff";
			$txtColors["Musta"] = "#000";
			
			// default colors
			$bgColor = "#ddd";
			$txtColor = "#000";
			
			// check if radios have been checked
			if(isset($_POST['bg'])) {
				$bgColor = $_POST['bg'];
			}
			if(isset($_POST['txt'])) {
				$txtColor = $_POST['txt'];
			}
			
			// style definitions
			$style = <<<EOD
				<style type='text/css'>
					body {
						background-color: $bgColor;
						color: $txtColor;
					}
					
					td {
						border: 1px solid black;
					}
				</style>
EOD;
		
			// creating the form
			$stuff = "
				<form method='post' action='h02t02.php'>
					<table>
						<tr><td>Taustaväri:</td><td>";
			foreach($bgColors as $color => $code) {
				$stuff .= "<input type='radio' name='bg' value='$code'>$color<br/>";
			}
			
			// adding to the form
			$stuff .= "</td></tr>
				<tr><td>Tekstiväri:</td><td>";
			foreach($txtColors as $color => $code) {
				$stuff .= "<input type='radio' name='txt' value='$code'>$color<br/>";
			}
			
			// finishing the form
			$stuff .= "</td></tr></table>
				<input type='submit' name='butan'></form>";
			
			echo $stuff;
			echo $style;
		?>
	</body>


</html>