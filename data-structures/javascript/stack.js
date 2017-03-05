// Ավելացված ECMAScript 2015 ստանդարտում, class֊ը "սինտակտիկ շաքար" է JavaScript֊ում 
// կիրառվող պրոտոտիպերի վրա հիմնված ժառանգականության վրա
class Stack {
  // constructor մեթոդը հատու կ մեթոդ է կլասսով ստեղծված օբյեկտը ինիցիալիզացնելու համար։ 
  // Ամեն կլասսում հնարավոր է հայտարարել միայն մեկ constructor
  constructor() {
    // տվյալ կլասսի համար ստեղծում է դատարկ array
    this.elements = []
    // վերագրում է 0 տվյալ կլասսի count֊ին
    this.count = 0
  }
  
  // կլասսի մեթոդ, որը վերցնում է մեկ արգումենտ element անունով
  push(element) {
    // վերևում հայտարարված elements array֊ին ավելացնում է նոր էլեմենտ 
    this.elements.push(element)
    // ինչից հետո թարմացնում է array֊ում գտնվող էլեմենտների թիվը խորհրդանշող փոփոխականը
    this.count += 1
  }
  
  // կլասսի մեթոդ  
  pop() {
    // եթե count փոփոխականի արժեքը զրոյից բարձր է, նվազեցնում է այն մեկով
    if(this.count > 0) {
      this.count -= 1
    } 
    //  եթե ոչ, նետում է error, նշելով, որ դատարկ stack֊ից հնարավոր չէ էլեմենտ հանել
    else {
      throw new Error("Can't remove from empty stack")  
    }
    // և հանում array֊ի առաջին էլէմենտը
    this.elements.pop()
  }
  
  // վերադարձնում է stack֊ի առաջին էլեմենտը
  peek() {
    // եթե stack֊ը դատարկ է, նետում է error
    if (this.count < 1) {
      throw new Error("Stack empty. Can't return peek element.")
    }
    return this.elements[0]
  }
  
  // վերադարձնում է stack֊ի վերջին էլեմենտը
  tail() {
    // եթե stack֊ը դատարկ է, նետում է error
    if (this.count < 1) {
      throw new Error("Stack empty. Can't return back element.")
    }
    return this.elements[this.elements.length - 1]
  }
  
  // վերադարձնում է stack֊ի երկարությունը
  length() {
    return this.count
  }
}
