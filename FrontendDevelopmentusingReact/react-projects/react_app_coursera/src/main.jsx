import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import './index.css'

// learning JSX
// const greeting = <h1>Welcome to React</h1>
// const greeting2 = React.createElement('h2',null,'Welcome Dear');

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <App/>
  </React.StrictMode>,
)
