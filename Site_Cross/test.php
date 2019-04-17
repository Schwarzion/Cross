<?php require('connexion.php'); 

$Nom = $_POST['nom'];
$Prenom = $_POST['prenom'];

if (isset ($Nom) && isset ($Prenom))
{
	$query = "SELECT RFID FROM eleve WHERE Nom = '$Nom' AND Prenom = '$Prenom' ;";
	try {
			$pdo_select = $pdo->prepare($query);
			$pdo_select->execute();
			$RFID = $pdo_select->fetchAll();
		} catch (PDOException $e){ echo 'Erreur SQL : '. $e->getMessage().'<br/>'; die(); }   
	}
	
$query_eleve = "SELECT * FROM eleve ORDER BY Nom ASC;";
  try {
	$pdo_select_tab = $pdo->prepare($query_eleve);
	$pdo_select_tab->execute();
	$NbreData = $pdo_select_tab->rowCount();	// nombre d'enregistrements (lignes)
	$eleve = $pdo_select_tab->fetchAll();
  } catch (PDOException $e){ echo 'Erreur SQL : '. $e->getMessage().'<br/>'; die(); }
  
  $query_classement = "SELECT * FROM classement WHERE Eleve_rfid = '$RFID'  ORDER BY Classement ASC;";
  try {
	$pdo_select_class = $pdo->prepare($query_classement);
	$pdo_select_class->execute();
	$NbreData = $pdo_select_class->rowCount();	// nombre d'enregistrements (lignes)
	$Classement = $pdo_select_class->fetchAll();
  } catch (PDOException $e){ echo 'Erreur SQL : '. $e->getMessage().'<br/>'; die(); }
?>

<form method="post" action="test.php"> 
		<p>Votre nom   :<input type="text" name="nom" />		</p>
		<p>Votre prenom   :<input type="text" name="prenom" />  </p>
		<input type="submit" value="OK" name="validation" />
	</form>
<?php
	if ($NbreData != 0) 
{
?>
	<table border="2">
	<thead>
		<tr>
			<th>Nom</th>
			<th>Prenom</th>
			<th>RFID</th>
		</tr>
	</thead>
	<tbody>
	
	Votre RFID : <?php 
	foreach ( $eleve as $row ) 
	{
		?>
		<tr>
			<td><?php echo $row['Nom']; ?></td>
			<td><?php echo $row['Prenom']; ?></td>
			<td><?php echo $row['RFID']; ?></td>
		</tr>
		<?php
	}	
	?>
	</body>
	</table>
	<?php
} else { ?>
	pas de données à afficher
	<?php
}
?>

</body>
</html>




SELECT jeux_video.nom, proprietaires.prenom
FROM proprietaires, jeux_video
WHERE jeux_video.ID_proprietaire = proprietaires.ID