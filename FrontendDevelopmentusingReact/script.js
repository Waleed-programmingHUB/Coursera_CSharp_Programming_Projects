 // Dom manulpulation 
 const taskList = document.querySelector(".todo-item"); // Unordered list 
 const taskInput = document.querySelector("#txt"); // Input text field
 const addEvent = document.querySelector("#AddTodo"); // Button ID Evemt
 // Event Listener of the Add todo Button
 addEvent.addEventListener('click',()=>{
   if (taskInput.value.trim() !== "") {
     var li = document.createElement("li");
     li.textContent = taskInput.value;
     taskList.appendChild(li);
     taskInput.value = "";
 } else {
     alert("Please enter a task.");
 }
 })