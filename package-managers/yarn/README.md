# <b>Yarn (Յարն)</b>

## <b>Ինչու Yarn</b>
Yarn֊ը փաթեթների (packages) ներբեռնումից անմիջապես հետո քեշավորում է դրանք, ինչի հարկավոր չի լինում դրանք կրկին ներբեռնել։ Այն նաեւ ասինխրոնիզացնում պրոցեսները, որի շնորիվ ռեսուրսները ուտիլիզացվում են մաքսիմալ եւ արագագործությունը անցնում է բոլոր սպասելիքները։ 


## <b>NPM-ի կամայական հրամանները Yarn-ում</b>

|NPM հրամանը | Yarn հրամանը| Նկարագրությունը (_որը որ անհրաժեշտ է_)|
|:---|:---|---|
|npm install|yarn  <br/> yarn install|Կկատարի *package.json* ֆայլում նշված փաթեթների տեղադրում։|
| npm install `pkg-name` <br/> npm install --save `pkg-name`| yarn add `pkg-name`|Ի սկզբանե Yarn-ը ավելացնում է *pgk-name* փաթեթի տվյալները package.json եւ yarn.lock ֆայլերում։|
|npm install  `pkg-name@1.0.0` | yarn add `pgk-name@1.0.0`|
|npm  install `pkg-name` --save-dev| yarn add `pkg-name` --dev|  
|npm  install `pkg-name` --peer| yarn add `pkg-name`--peer|  
|npm  install `pkg-name` --optional| yarn add --optional|  
|npm install -g `pkg-name`|yarn add global `pkg-name`|
|npm update | yarn upgrade|Ուշադրություն դարձրեք նրան, որ Yarn-ում **upgrade**֊ի փոխարեն օգտագործված է **upgrade**։
|npm uninstall `pkg-name`| yarn remove `pkg-name`|
|npm run `scrit-name`| yarn run `script-name`|
|npm init | yarn init|
|npm pack | yarn pack| Ստեղծում է package.json-ում նշված կախվածությունների (dependencies) փաթեթների սեղմված *gzip* արխիվ ֆայլը։|
|npm link | yarn link|
|npm outdated | yarn outdated|
|npm publish | yarn publish|
|npm run | yarn run|
|npm cache clean | yarn cache clean|
|npm login | yarn login (and logout)|
|npm test | yarn test|
|npm install --production | yarn --production|
|npm  --version | yarn version|
|npm  info | yarn info|



### <b>Yarn֊ի նոր հրամանները</b>
|Yarn հրամանը | Նկարագրությունը|
|---|---|
|yarn why `pkg-name` |Հետազոտում եւ կառուցում է *pkg-name* փաթեթի մասին մանրամասն հաշվեգրություն, թե ինչի համար է օգտագործված։|
|yarn clean | Մաքրում է անգործունյան պանակները (folders) եւ ֆայլերը կախվածությունների պանակից|
|yarn licenses ls | Հետազոտում եւ կառուցում է կախվածությունների պանակում առկա փաթեթների լիցենզիաների տեսակները եւ մատնանշում հղումները |
yarn licenses generate-disclaimer | Automatically create your license dependency disclaimer|

## <b>Հղումներ</b>
[npm](../npm)

