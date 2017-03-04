react Շպարգալկա
---------------

# Functional Components

```jsx
import React from 'react';

const Application = ({name, handler}) => {
  return (
    <div onClick={handler}> Hello {name} </div>
  );
};
```
Տվյալ կոդով ստեղծվում է custom էլեմենտ, որին ինիցիալիզացնելու ժամանակ կարող է տրվել երկու արգումենտ՝ name և handler: Էլեմենտը վերադարձնում է եզակի դիվ էլեմենտ, որի մեջ օգտագործվում են custom Application էլեմենտին տրված արգումենտները՝ handler ֆունկցիան կանչվում է դիվ էլեմենտը քլիք անելուց, իսկ name արգումենտը դրվում է Hello բառից հետո և տպվում որպես դիվի տեքստ: Էլեմենտը չի պահպանում սեփական վիճակը (state): 

# Components with state

```jsx
import React, {Component} from 'react';

class Box extends Component {

  constructor() {
    this.state = {did_click:false};
	this.handler = this.handler.bind(this);
  }

  handler(e) {
    console.log("Clicked!");
	this.setState({did_click:true})
  }

  render() {
  
    return (
	  <div onClick={this.handler}>
        Hello World, click status? {this.state.did_click}
	  </div>
    ) 
  }
};
```
