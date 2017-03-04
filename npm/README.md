## NPM հրամաններ

### Package—ների տեղադրում
Հրաման  | Նշանակություն
------------- | -------------
**npm install** *կամ* **npm i**  | local (նույն պրոյեկտի մեջ` **node_modules** folder-ում)  տեղադրում է **package.json** ֆայլի **dependencies**-ներում գրված բոլոր package-ները 
**npm install** *package*  | local (նույն պրոյեկտի մեջ` **node_modules** folder-ում) տեղադրում է **package** անվանումով package-ը
**npm install** *package@1.1.7*  | local (նույն պրոյեկտի մեջ` **node_modules** folder-ում) տեղադրում է ***1.1.7*** տարբերակի **package** անվանումով package-ը 
**npm install** *package* **--save**  | local (նույն պրոյեկտի մեջ` **node_modules** folder-ում) տեղադրում է **package** անվանումով package-ը, **package.json**-ում ավելացնելով package-ի մասին ինֆորմացիա։
**npm install** *package* **-g**  | global (node.js-ի folder-ում) տեղադրում է **package** անվանումով package-ը։

### Package—ների ջնջում
Հրաման  | Նշանակություն
------------- | -------------
**npm uninstall** *package*  | local (նույն պրոյեկտի մեջ` **node_modules** folder-ից) ջնջում է **package** անվանումով package-ը
**npm uninstall** *package* **-g**  | global (node.js-ի folder-ում) ջնջում է **package** անվանումով package-ը։

### Սկրիպտների մեկնարկ
Հրաման  | Նշանակություն
------------- | -------------
**npn run** *command* | մեկնարկում է **package.json** ֆայլի **scripts**-ում գրված ***command*** -ին համապատասխանող հրամանը
**npm start**  | մեկնարկում է **package.json** ֆայլի **scripts**-ում գրված **start**-ին համապատասխանող հրամանը
