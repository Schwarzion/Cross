<?php require 'modele.php' ?>
<?php mb_internal_encoding('UTF-8'); ?>
<?php
if (!isset($_POST['saisie'])){
    require 'index.php';
}
else {
    $Nom = $_POST["Nom"];
    $Prenom = $_POST["Prenom"];
    
    $RFID = getRFID($Nom, $Prenom);
    if ($RFID != NULL)
    {
        foreach ( $RFID as $row ) 
            $RFID = $row['RFID'];

        $Parcours = getCourse($RFID);
        foreach ($Parcours as $row)
            $Parcours = $row['Course_id'];

        $classement = getClassement($Parcours);
        $position = getPosition($RFID, $Parcours);
        foreach ($position as $row)
            $position = $row['Classement'];
        
        $chrono = getChrono($RFID);
        foreach ($chrono as $row)
            $chrono = $row['Chronometre'];

        require 'vue_classement.php';
    }
    else if ($RFID == NULL) 
        echo "Erreur, aucun RFID trouv&eacute;";
}
?>

