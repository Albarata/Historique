Application de gestion des évolutions d'un objet, avec historique.

J'ai isolé la partie récupération de données et mis derrière une interface pour pouvoir changer facilement la méthode d'input (console ici, on pourrait lire via fichier ou appel API). J'ai ajouté des tests unitaire sur le service et la partie input justement.

Utilisation:
- Taper 1 pour mettre à jour l'état de l'objet
- Taper 2 pour afficher l'historique des modifications
- Toute autre saisie arrête le programme

Exemple de saisie:
- 1
- step1
- description1
- 1
- step2
- description2
- 2
- \n

Scénario permettant de faire deux màj (setp1 et step2) puis afficher l'historique, avant de fermer.
