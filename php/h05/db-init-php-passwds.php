<?php

require_once('/home/L4929/php-dbconfig/db-init.php');
require_once 'PasswordLib.phar';
$lib = new PasswordLib\PasswordLib();

$sql = "DROP TABLE IF EXISTS henkilotpwds";
$affected_rows = $db->exec($sql);
echo $affected_rows . "taulua poistettiin<hr>\n";

$sql = <<<SQLEND
CREATE TABLE henkilotpwds (
  tunnus      varchar(6) not null,
  sukunimi    varchar(128) not null,
  etunimi     varchar(128) not null,
  osoite      varchar(255) not null,
  puhnro      varchar(64) not null,
  email       varchar(128),
  password    varchar(64),
  auth        varchar(5) not null,
  PRIMARY KEY (tunnus),
  UNIQUE (email)
);
SQLEND;

$affected_rows = $db->exec($sql);
echo $affected_rows . " taulua lisättiin<hr>\n";
 


$password = "admin";
$hash = $lib->createPasswordHash($password,  '$2a$', array('cost' => 12));
$sql = "INSERT INTO henkilotpwds ( tunnus, sukunimi,etunimi,osoite, puhnro,email, password, auth ) VALUES ( 'admin','Administrator','Admin','AdminAddress','000 666','admin@abcde.fi', '$hash', 'admin')";
$affected_rows = $db->exec($sql);
echo $affected_rows . " riviä lisättiin<hr>\n";


$password = "Jussi";
$hash = $lib->createPasswordHash($password,  '$2a$', array('cost' => 12));
$sql = "INSERT INTO henkilotpwds ( tunnus, sukunimi, etunimi, osoite, puhnro, email, password, auth ) VALUES ( 'L4929', 'Surma-Aho', 'Jussi', 'Roninmäentie 6 N 19', '0000000','pena@server.fi', '$hash', 'guest')";
$affected_rows = $db->exec($sql);
echo $affected_rows . " riviä lisättiin<hr>\n";


$password = "sala";
$hash = $lib->createPasswordHash($password,  '$2a$', array('cost' => 12));
$sql = "INSERT INTO henkilotpwds ( tunnus, sukunimi,etunimi,osoite, puhnro,email, password, auth ) VALUES ( 'kanvis','Kanninen','Visa','Kumpiuja 2','11234','kane@abcde.fi', '$hash', 'guest')";
$affected_rows = $db->exec($sql);
echo $affected_rows . " riviä lisättiin<hr>\n";


echo "Done!\n";
?>