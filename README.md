# Application de gestion de stock

# Définition des concepts

    * Objectifs

    L'objectif principale de réaliser une application web en utlisant C# et Asp.net pour la gestion du stock,
    la commande de produit par des personnel locaux d'une entreprise et la gestion de bon de commande. 
 
    * Importance de la gestion de stock
		La gestion de stock est tres important car elle assure la disponibilites des article pour répondre à la demande.

    * Les facteurs important pour la gestion de stock:
        Gestion des coûts
        Flux de trésorerie
        Satisfaction de personnel  
        Etat financier 
        Relations fournisseur
        Prise de décisions stratégiques
        Visibilité sur les stocks.

    * Typologie de notre Stock
        On distingue plusieur type de stockage a savoir:
        - Stocks de production/Commercialisation (Stock de produits finis, Stock de marchandises etc.)
        - Stocks hors production( Stock de pieces de rechange et accessoires, Stock d'emballages, Stock de pieces des maintenance, Stock de consommables, etc)
        - Stocks Classification par fonction de stock (Stock de securite, Stock d'anticipation,Stock de speculatif, etc)
        - 
        Ici nous allons travailler sur le type de Stocks hors production et Stocks Classification par fonction de stock
        - Stocks hors production (Stock de pièces de maintenance des machines et des consommables) 
                Ces pièces n'interviennent pas dans la production du produit fini mais permettent l'entretien et la réparation des machines. Les consommables de bureau rentrent également dans cette catégorie.
        - Stocks Classification par fonction de stock(Stock par anticipation)
            La société achète et garde le produit en stock si nécessaire a une duree donné. Ce stock est dite stock par anticipation peut être justifié par une augmentation des prix ou par une augmentation saisonnière de la demande, ou par une grève menaçante. Cette type créant une forte couverture de stock avant que la demande de leurs produits ne soit exceptionnellement haute. 

    # Lieu de stock(le magasin)
        C'est un espace de stockage où l'on range le matériel et les produits dans des conditions de stockage spécifiquement adaptées. selon un ordre bien précis. Il permet de garder un état juste des articles et assure pour chaque article un point de gestion entre l'approvisionnement et la consommation. C'est le lieu où l'on pointe les entrées et les sorties. 
		Le magasin offre des emplacements de stockage bien matérialisés, ce qui permet de réaliser des inventaires afin de garantir l'exactitude permanente des quantités de produits disponibles.
 
		

# Besoin et cahier de charge

Pour realiser notre application Gestion de Stock nous elaborons les besoins suivants:
    1- Lister les articles pres a etre commander a la page index de l'application avec une zone de recherche rapide.
    2- Pour commander un article il faut prealablement avoir un identifiant.
    3- Chaque identifiant a une ou plusieur role qui lui permet de realiser certaine tache.
        Chaque role a une interface d'administration
            SuperAdmin: Informaticien
                Installation et configuration de l'application, l'informaticen a tout les droit possible qui lui permet de mettre en
                place notre application:
                    Gestion et Configuration de l'application et la base de donnees,
                    Gestion d'agences, Departement ous Service,
                    Gestion des utlisateur.
            Admin : Chef de Service
                Le Chef de Service Logistique Assure la satisfaction de  stock a un niveau qui répond à la demande de nos personnel 
                    et conforme aux politiques de stockage de notre reglement interieur,  
                    Ces politiques couvrent également la façon dont l'entreprise affectera les coûts aux stocks, via des méthodes d'évaluation des coûts telles que les stocks premier entré, premier sorti et
                    premier entré, dernier sorti, et évaluera l'inventaire, à l'aide de méthodes telles que la classification ABC pour se concentrer sur les articles utiliser de facons continuelle.
            Magasinier : Gestionnaire de stock
                Le magasinier assure la bonne gestion de stock conformenet a la politique interne,ce qui détermine la quantité, la qualité d'inventaire stocké et l'emplacement.
            AssistantLogistique : Logsticien

            ResponsableLogistique : Logsticien

            GestionnaireDestock : Gestionnaire(Comptale)

            Client: Personnel qui peuvent commander des produits
                utilisateur Simple (personnel d'un autre service) de consulter les produits en stock et de commander, ou de demander un achat un produit qui ne figure pas en stock.
# Architecture du projet

- Creation du projet
    Blanck Solution : "Application de gestion de stock"
        1-ASP.NET Core Web API: "EBS.API"
            Reference: EBS.Business et EBS.DTO
        2-Class Library: "EBS.Business"
            Reference: EBS.DaTaAccess
        3-Class Library: "EBS.DaTaAccess"
            Reference: EBS.Entity
        4-Class Library: "EBS.DTO"
            Reference: EBS.Entity
        5-Class Library: "EBS.Entity"
            Reference: NULL
        6-ASP.NET Core Web App(Model-View-Controller) : EBS.WEebUI
            Reference: DaTaAccess
