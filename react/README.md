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
