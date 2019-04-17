<?php
function getBdd() {
    $bdd = new PDO('mysql:host=localhost; dbname=cross;charset=utf8','root','',array(PDO::ATTR_ERRMODE=> PDO::ERRMODE_EXCEPTION));
    return $bdd;
}

function getClassement($Parcours) {
    $bdd = getBdd();
    $classement = $bdd->query('SELECT * FROM classement, eleve WHERE "'.$Parcours.'" = classement.Course_id AND eleve.RFID = classement.Eleve_rfid ORDER BY classement.Classement ASC');
    $result = $classement->fetchAll();
    return $result;
}

function getRFID($Nom, $Prenom) {
    $bdd = getBdd();
    $RFID = $bdd->query('SELECT RFID FROM eleve WHERE Nom = "'.$Nom.'" AND Prenom = "'.$Prenom.'"');
    $result = $RFID->fetchAll();
    return $result;
}

function getPosition($RFID, $Parcours) {
    $bdd = getBdd();
    $position = $bdd->query('SELECT Classement FROM classement WHERE Eleve_rfid = "'.$RFID.'" AND Course_id = "'.$Parcours.'"');
    $result = $position->fetchAll();
    return $result;
}

function getCourse($RFID) {
    $bdd = getBdd();
    $course = $bdd->query('SELECT Course_id FROM classement WHERE Eleve_rfid = "'.$RFID.'"');
    $result = $course->fetchAll();
    return $result;
}

function getChrono($RFID) {
    $bdd = getBdd();
    $chrono = $bdd ->query('SELECT Chronometre FROM classement WHERE Eleve_rfid = "'.$RFID.'"');
    $result = $chrono->fetchAll();
    return $result;
}
?>