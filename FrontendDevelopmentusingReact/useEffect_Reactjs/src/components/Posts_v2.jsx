import react, { useEffect, useState } from "react";
import axios from "axios";

const Posts_v2 = ()=>{

    const [data,SetData] = useState([]);

    useEffect(()=>{
        let _Data = async ()=>{
            const fetchdata = await axios.get('https://jsonplaceholder.typicode.com/posts');
            SetData(fetchdata.data); 
        }
        _Data();
    },[]);


    return (
        <>
            <h2>Post Version 2 using Axios library</h2>
    <ul>
        {data.map(post => (
          <li key={post.id}>{post.title}</li>
        ))}
      </ul>
        </>
    )
}

export default Posts_v2;