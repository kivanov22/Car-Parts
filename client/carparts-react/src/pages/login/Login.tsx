import {useState} from 'react'
import Input from "../../components/inputs/Input"
import "./Login.scss"
import { useNavigate } from "react-router-dom";
import  { makeApiRequest } from "../../utils/newRequest";

interface UserData {
  username: string;
  password: string;
}

const Login = () => {
  const[values,setValues] = useState<UserData>({
    username:"",
    password:"",
  });

  const navigate = useNavigate();

  const handleSubmit = async(e: React.FormEvent<HTMLFormElement>) => {//event: React.FormEvent<HTMLFormElement
    e.preventDefault();

    try {
      const response = await makeApiRequest<void>('POST', 'https://localhost:7248/api/User/authenticate',values);

      navigate('/')
      console.log('User logged in successfully!');
    } catch (error) {
      
    }
  };

  const onChange = (name: keyof UserData, value: string) => {//name: keyof RegistrationFormData, value: string
    setValues({ ...values, [name]: value });
  };
  

  return (
    <form className='login' onSubmit={handleSubmit}>
      <h1>Login</h1>
      <Input label='Username' value={values.username} onChange={(value)=>onChange('username',value)}/>
      <Input label='Password' value={values.password} onChange={(value)=>onChange('password',value)}/>
      <button type='submit'>Login</button>
      <hr />
      <p>Not registered, click here!</p>
    </form>
  )
}

export default Login

