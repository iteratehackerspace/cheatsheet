## Git հրամաններ

### Ֆայլերի ինդեքսավորում
Հրաման  | Նշանակություն
------------- | -------------
**git add** *.*  | ինդեքսավորում է բոլոր փոփոխված ֆայլերը  
**git add** *file*  | ավելացնում է **file** ֆայլը  
**git add** *file1* *file2*  | ավելացնում է **file1** եւ **file2** ֆայլերը  

### Ֆայլերի ջնջում
Հրաման  | Նշանակություն
------------- | -------------
**git rm** *file*  | ջնջում է **file** ֆայլը  
**git rm** *file1* *file2*  | ջնջում է **file1** եւ **file2** ֆայլերը

### Ֆայլերի վերբեռնում
Հրաման  | Նշանակություն
------------- | -------------
**git pull**  | commit արված ֆայլերն ուղարկում է remote **master** branch
**git pull** *origin* *branch*  | commit արված ֆայլերն ուղարկում է remote **branch** branch

### Ֆայլերի ներբեռնում
Հրաման  | Նշանակություն
------------- | -------------
**git push**  | remote **master** branch-ից բեռնում է փոփոխությունները  
**git push** *origin* *branch*  | remote **branch** branch-ից բեռնում է փոփոխությունները  

### Branch-ների փոխատեղում
Հրաման  | Նշանակություն
------------- | -------------
**git checkout -b** *branch*  | ստեղծում է **branch** անվանումով նոր branch  
**git checkout** *branch*  | անցում է կատարում առկա **branch** անվանումով branch  

###Այլ հրամաններ
Հրաման  | Նշանակություն
------------- | -------------
**git clone** *repositoryURL*  | կլոնավորում է **repositoryURL** հասցեից remote master branch
**git commit -m** *'text'*  | ինդեքսավորված ֆայլերին տալիս է **'text'** մեկնաբանությունը  
**git status**  | ցույց է տալիս ընթացիկ փոփոխված ֆայերի ցանկը  
**git init**  | ինիցիալիզացնում նոր repository  
**git diff**  | ցուցադրում է փոփոխությունները 
**git branch**  | ցուցադրում է local branch-երի ցանկը

## Պարզագույն հրամանների օգտագործման օրինակներ
### Repository-ի բեռնում եւ նախապատրաստում աշխատանքի
```bash
git clone https://github.com/iteratehackerspace/cheatsheet
cd repository
```
### փոփոխությունների կատարում եւ վերբեռնում
```bash
git checkout -b ubunutu-commands
git add .
git commit -m 'new section create'  
git push origin ubunutu-commands  
```

