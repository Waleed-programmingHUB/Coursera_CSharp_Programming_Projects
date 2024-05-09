import { useEffect, useState } from "react";

function Counter_useeffect(){
   const [count,setCount]= useState(0);
   
   // UseEffect in ReactJS
   useEffect(()=>{
    console.log(`Component Mounted`);
    const handleClick = setCount((c)=>c+1);
    document.addEventListener('click',handleClick);

    return ()=>{
        console.log(`Component Unmounted`);
        document.removeEventListener('click',handleClick);
    }
   },[]);

   useEffect(()=>{
    console.log(`Count updated`);
    document.title = `Count :${count}`;
   },[count])

   return <>
    <h2>Count :{count}</h2>
    <button onClick={()=> setCount(count +1)}>Count</button>
    </>
}

export default Counter_useeffect;