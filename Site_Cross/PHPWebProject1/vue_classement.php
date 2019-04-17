<html>
    <head>
        <link rel="stylesheet" type="text/css" href="styles.css" />
        <title>Classement</title>
    </head>
    <body>
        <h1>Vous &ecirc;tes arriv&eacute; en position num&eacute;ro : <?php echo $position; ?><br /> Votre temps : <?php echo $chrono; ?> <br /></h1>
        <br>
       <div class="datagrid"><table>
            <thead>
                <tr>
                    <th><b>Nom</b></th>
                    <th><b>Pr&eacute;nom</b></th>
                    <th><b>Classement</b></th>
                    <th><b>Chronom&egrave;tre</b></th>
                </tr>
            </thead>
                <?php foreach ($classement as $row)
                      { ?>
                          <tr>
                              <td><?php echo $row['Nom'] ?></td>
                              <td><?php echo $row['Prenom'] ?></td>
                              <td><?php echo $row['Classement'] ?></td>
                              <td><?php echo $row['Chronometre'] ?></td>
                          </tr> <?php                                 
                      } ?>
        </table></div>
    </body>
</html>