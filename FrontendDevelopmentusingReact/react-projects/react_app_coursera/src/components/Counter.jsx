import React from "react";
// component class counter
class Counter extends React.Component {
  constructor() {
    super(props);
    this.state = {
      count: 0
    };
  }

  render() {
    return (
      <>
        <p>You Click the button {this.state.count} times.</p>
        <button
          onClick={() => 
            this.setState({count:this.state.count + 1})
          }
        >
         
          Click Me
        </button>
      </>
    )
  }
}

export default Counter;
