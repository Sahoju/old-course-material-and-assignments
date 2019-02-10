<!DOCTYPE html>
<html>
	<head>
		<title>Harjoitus 2, tehtävä 3</title>
		<meta charset="utf-8">
	</head>
	
	<body>
		<?php
			$stuff = <<<EOD
				<form method='post' action='{$_SERVER['PHP_SELF']}'>
					<select name='category[]' size='3' multiple>
						<option value='trump'>Trump</option>
						<option value='sisailma'>Sisäilmaongelmat</option>
						<option value='dokkari'>Perjantai-dokkari</option>
					</select><br/>
					<input type='submit' name='butan'><br/><br/>
EOD;

			echo $stuff;
			
            if(!isset($_POST['category'])) exit();
        
			foreach ($_POST['category'] as $choice) {
				switch($choice) {
					case 'trump':
						echo "Yle-uutisia Trumpista:<br/>
							<a href='https://yle.fi/uutiset/3-10394277'>Trumpin ex-avustaja Papadopoulosille kahden viikon vankeusrangaistus</a><br/>
							<a href='https://yle.fi/uutiset/3-10394347'>Obama suomi Trumpia ja ihmetteli republikaaneja - Trump sanoi nukahtaneensa kesken puheen</a><br/>
							<a href='https://yle.fi/uutiset/3-10394266'>Trump haluaa oikeusministerin tutkivan haamukirjoittajan henkilöllisyyden - The New York Timesin mukaan kyse on vallan räikeästä väärinkäytöstä</a><br/><br/>";
						break;
					case 'sisailma':
						echo "Yle-uutisia sisäilmaongelmista:<br/>
							<a href='https://yle.fi/uutiset/3-10392380'>Joukko Kätilöopistolla sairastuneita kätilöitä hakee lähes miljoonan euron korvauksia – Viimeinen työvuoro vei Tanja Mäkisen sairaalaan</a><br/>
							<a href='https://yle.fi/uutiset/3-10362771'>Nivelsärkyjä, kielen kutinaa ja iho-oireita: Jopa uusia kouluja tyhjennetään sisäilmaongelmien takia – Kuka kantaa vastuun?</a><br/>
							<a href='https://yle.fi/uutiset/3-10254105'>Oulun tragedia vei yhtäkkiä terveyden kymmeniltä poliiseilta, myös Timo Mälliseltä – tapaus kiteyttää kaiken siitä, miksi sisäilmaongelmia ei saada Suomessa kuriin</a><br/><br/>";
						break;
					case 'dokkari':
						echo "Yle-Areenan Perjantai-dokkareita:<br/>
							<a href='https://areena.yle.fi/1-50002197'>Tapparan nainen</a><br/>
							<a href='https://areena.yle.fi/1-50001869'>Sokea äiti</a><br/><br/>";
						break;
				}
			}
		?>
	</body>
</html>