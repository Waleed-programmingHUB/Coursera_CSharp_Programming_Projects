import { useEffect, useState } from "react";

function Posts() {
    const [data, setData] = useState([]);
  const list = [
    {
      id: 1,
      title: "this is a testing posts",
    },
    {
      id: 2,
      title: "this is a testing posts",
    },
    {
      id: 3,
      title: "this is a testing posts",
    },
    {
      id: 4,
      title: "this is a testing posts",
    },
  ];

  useEffect(() => {
    async function getPosts(){
        const items = await fetch(list);
        const data_item = items.json();
        setData(data_item);
    }
    getPosts();
  }, []);



  return (
    <>
      <h2>Post Works</h2>
      <p>Post data from Server</p>
      <ul>
        {data.map((i)=>{
            <li key={i.id}>{i.title}</li>
        })}
      </ul>
    </>
  );
}

export default Posts;
