import { useContext } from "react";

// Function Component
function Header(){
    const theme = useContext(ThemeContext)
    return <>
    <header>
        <h2>
            Learn React
        </h2>
    </header>
    </>
}
export default Header;