// Counter using React States useState
// Component
function Counter_state(){
    const [count,setCount] = useState(1); // destructring the data
   function increment(){
     setCount(count + 1)
   }
   
    return (
     <>
     <h2>Counter : {count}</h2>
     <button onClick={increment}>Click</button>
     <br />
     <br />
     </>
    )
   }
   
export default Counter_state;