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
// La requete
$query = "SELECT * FROM classement WHERE ID_course = 2 ORDER BY Position ASC  ";
  try {
	$pdo_select = $pdo->prepare($query);
	$pdo_select->execute();
	$NbreData = $pdo_select->rowCount();	// nombre d'enregistrements (lignes)
	$rowAll = $pdo_select->fetchAll();
  } catch (PDOException $e){ echo 'Erreur SQL : '. $e->getMessage().'<br/>'; die(); }
// --------------------------------
// affichage
if ($NbreData != 0) 
{
?>
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
			<td><?php echo $row['Position']; ?></td>
			<td><?php echo $row['Nom']; ?></td>
			<td><?php echo $row['Prenom']; ?></td>
		</tr>
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