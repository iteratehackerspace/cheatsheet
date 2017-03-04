```
Queue֊ն աբստրակտ data structure է, բավականին նման Stack֊ին։ Ի տարբերություն Stack֊ի,
Queue֊ն "բաց" է երկու կողմից էլ։ Մի կողմը միշտ օգտագործվում է տվյալներ ներմուծելու (enqueue) 
համար, մյուսը՝ հանելու (dequeue): Queue֊ն հետևում է First-In-First-Out մեթոդոլոգիային, ինչը
նշանակում է, որ առաջինը ներմուծված տվյալների հետ են առաջինը իրականացվում գործողություններ։
```
```javascript
// Ավելացված ECMAScript 2015 ստանդարտում, class֊ը "սինտակտիկ շաքար" է JavaScript֊ում 
// կիրառվող պրոտոտիպերի վրա հիմնված ժառանգականության վրա  

class Queue {    
  // constructor մեթոդը հատուկ մեթոդ է կլասսով ստեղծված օբյեկտը ինիցիալիզացնելու համար։ 
  // Ամեն կլասսում հնարավոր է հայտարարել միայն մեկ constructor
  constructor() {  
    // տվյալ կլասսի համար ստեղծում է դատարկ array  
    this.elements = new Array()  
    // վերագրում է 0 տվյալ կլասսի count֊ին   
    this.count = 0  
  }  
  
  // կլասսի մեթոդ, որը վերցնում է մեկ արգումենտ element անունով  
  enqueue(element) {  
    // վերևում հայտարարված elements array֊ին ավելացնում է նոր էլեմենտ  
    this.elements.push(element)  
    // ինչից հետո թարմացնում է array֊ում գտնվող էլեմենտների թիվը խորհրդանշող փոփոխականը  
    this.count += 1  
  }  
  
  // կլասսի մեթոդ  
  dequeue() {  
    // եթե count փոփոխականի արժեքը զրոյից բարձր է, նվազեցնում է այն մեկով  
    if(this.count > 0) {  
      this.count -= 1  
    } 
    //  եթե ոչ, կոնսոլում տպում է, որ դատարկ queue֊ից իհարկե հնարավոր չէ էլեմենտ հանել  
    else {  
      console.log("Can't dequeue from empty queue")  
    }  
    // և հանում array֊ի վերջին էլէմենտը  
    return this.elements.shift()  
  }  
  
  // վերադարձնում է queue֊ի առաջին էլեմենտը  
  peek() {  
    return this.elements[0]  
  }  
  
  // վերադարձնում է queue֊ի վերջին էլեմենտը  
  back() {  
    return this.elements[this.elements.length - 1]  
  }  

  // վերադարձնում է queue֊ի երկարությունը  
  length() {  
    return this.count  
  }  
}  
```
