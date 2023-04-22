import {useState} from 'react'
import Input from "../../components/inputs/Input"
import "./Login.scss"



const Login = () => {
  const[values,setValues] = useState({
    username:"",
    password:"",
  });

  const inputs =[
    {
      id:1,
      type:"text",
      placeholder:"Username",
      label:"Username",
    }
  ]

  return (
    <form className='login'>
      <h1>Login</h1>
      {/* <Input /> */}
      <hr />
      <p>Not registered, click here!</p>
    </form>
  )
}

export default Login

// <label htmlFor="">Username</label>
// <input type="text" placeholder='enter username'/>
// <label htmlFor="">Password</label>
// <input type="text" placeholder='enter password'/>