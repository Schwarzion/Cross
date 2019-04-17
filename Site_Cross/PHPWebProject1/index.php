<html>
    <head>
        <link rel="stylesheet" type="text/css" href="styles.css" />
        <title> Cross </title>
    </head>
    <body>
    <?php mb_internal_encoding('UTF-8'); ?>
	    <form method="POST" action="controleur.php">
	        <p>Votre nom    : <input type="text" name="Nom" /></p>
	        <p>Votre prenom    : <input type="text" name="Prenom" /></p>
	        
	        <input type="submit" value="OK" name="saisie" />
	    </form>
    </body>
</html>