// Basics of ReactJS

import "./App.css";
// import Header from "./components/Header";
import Footer from "./components/Footer";
import { useState } from "react";
import Counter_state from "./components/Counter_state";
import Counter_useeffect from "./components/Counter_useeffect";
import Post from "./components/Post";
// import Counter from './components/Counter';
import { useContext } from "react";
// Context Provider
// const ThemeContext = React.createContext('light');

function Greeting(props) {
  return (
    <>
      <p>React Props {props.title}</p>
    </>
  );
}

//  class Counter extends React.Component {
//   constructor(props) {
//     super(props);
//     this.state = {
//       count: 0
//     };
//   }

//   render() {
//     return (
//       <div>
//         <p>You Click the button {this.state.count} times.</p>
//         <button
//           onClick={() =>
//             this.setState({count:this.state.count + 1})
//           }
//         >

//           Click Me
//         </button>
//       </div>
//     )
//   }
// }



// Function Component Header
function Header() {
  // const theme = useContext(ThemeContext);
  return (
      <header
        // style={{
        //   backgroundColor: theme === "light" ? "#fff" : "#262626",
        //   color: theme === "light" ? "#000" : "#fff",
        // }}
      >
        <h2>Learn React</h2>
      </header>

  )
}

function App() {
  return (
    <>
      {/* <ThemeContext.Provider value="dark"> */}
        <Header />
        {/* <Greeting title="Bismillah from Waleed Learning about React.JS for .NET Developer" />
        <br />
        <Post />
        <br /> */}
        <Footer />
      {/* </ThemeContext.Provider> */}
    </>
  );
}

export default App;
