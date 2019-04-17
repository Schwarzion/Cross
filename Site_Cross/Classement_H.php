<?php require('connexion.php'); ?>

<!DOCTYPE html>
<html>
<head>
	 <meta charset="utf-8" />
	 <title>Affichage simple avec Base de Donnees</title>
</head>
<body>

<?php
// --------------------------------
// --------------------------------
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
// --------------------------------
// La requete

$query_eleve = "SELECT * FROM eleve ORDER BY Nom ASC;";
  try {
	$pdo_select_tab = $pdo->prepare($query_tab);
	$pdo_select_tab->execute();
	$NbreData = $pdo_select_tab->rowCount();	// nombre d'enregistrements (lignes)
	$eleve = $pdo_select_tab->fetchAll();
  } catch (PDOException $e){ echo 'Erreur SQL : '. $e->getMessage().'<br/>'; die(); }
// --------------------------------
// affichage
?> Votre RFID : <?php
	 foreach ( $eleve as $row ) 
	{
		?>
		<tr>
			<td><?php echo $row['RFID']; ?></td>
		</tr>
		<?php
	}	
	
if ($NbreData != 0) 
{
?>
	<form method="post" action="Classement_H.php"> 
		<p>Votre nom   :<input type="text" name="nom" />		</p>
		<p>Votre prenom   :<input type="text" name="prenom" />  </p>
		<input type="submit" value="OK" name="validation" />
	</form>
	
	<table border="2">
	<thead>
		<tr>
			<th>Position</th>
			<th>Nom</th>
			<th>Prenom</th>
		</tr>
	</thead>
	<tbody>
<?php
	// pour chaque ligne (chaque enregistrement)
		foreach ( $rowAll as $row ) 
	{
		// DONNEES A AFFICHER dans chaque cellule de la ligne
?>
		<tr>
			<td><?php echo $row['Classement']; ?></td>
			<td><?php echo $row['Nom']; ?></td>
			<td><?php echo $row['Prenom']; ?></td>
		
<?php
	} // fin foreach
?>
	</tbody>
	</table>
<?php
} else { ?>
	pas de données à afficher
<?php
}
?>

</body>
</html>