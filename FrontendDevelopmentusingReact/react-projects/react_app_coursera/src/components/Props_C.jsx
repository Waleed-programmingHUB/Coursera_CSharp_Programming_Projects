// basics of react props
// functional based props
function Greeting(props){
    return (
    <>
    <h2>React Props {props.title}</h2>
    </>
    )
   }
  class Greetings extends React.Component{
    render(){
      return <h2>Message : {this.props.title}</h2>
    }
  }