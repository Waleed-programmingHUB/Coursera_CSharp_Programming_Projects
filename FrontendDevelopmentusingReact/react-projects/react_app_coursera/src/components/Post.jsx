import { useEffect, useState } from "react";

// Making API Calls with useEffect Hook
function Post() {
  // state
  const [posts, setPosts] = useState([]); /* Passing a Empty Array */

  // API Call using UseEffect
  useEffect(() => {
    async function fetchPost() {
      const response = await fetch(
        'https://jsonplaceholder.typicode.com/posts'
      );
      const data = await response.json();
      setPosts(data);
    }
    fetchPost();
  }, []);

  return (
    <>
      <h2>Post Works</h2>
      <ul>
        {posts.map((post) => {
          <li key={post.id}>
            {post.title}
          </li>
        })}
      </ul>
    </>
  );
}
export default Post;
