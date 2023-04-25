import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import "./Register.scss";
import Input from "../../components/inputs/Input";
import  { makeApiRequest } from "../../utils/newRequest";



interface UserData {
  firstName: string;
  lastName: string;
  username: string;
  email: string;
  password: string;
  confirmPassword: string;
}


const Register = () => {
  const [values, setValues] = useState<UserData>({
    firstName: "",
    lastName: "",
    username: "",
    email: "",
    password: "",
    confirmPassword: "",
  });

  const navigate = useNavigate();
 
  const handleSubmit = async(e: React.FormEvent<HTMLFormElement>) => {//event: React.FormEvent<HTMLFormElement
    e.preventDefault();

    try {
      const response = await makeApiRequest<void>('POST', 'https://localhost:7248/api/User',values);

      navigate('/')
      console.log('User registered successfully!');
    } catch (error) {
      
    }
  };

  const onChange = (name: keyof UserData, value: string) => {//name: keyof RegistrationFormData, value: string
    setValues({ ...values, [name]: value });
    // setValues({ ...values, [e.target.name]: e.target.value });
    //e: React.ChangeEvent<HTMLInputElement>
  };


  return (
    <form className="register" onSubmit={handleSubmit}>
      <h1>Register</h1>
      <Input label="First Name" value={values.firstName} onChange={(value)=>onChange('firstName',value)}/>
      <Input label="Last Name" value={values.lastName} onChange={(value)=>onChange('lastName',value)}/>
      <Input label="Username" value={values.username} onChange={(value)=>onChange('username',value)}/>
      <Input label="Email" value={values.email} onChange={(value)=>onChange('email',value)}/>
      <Input label="Password" value={values.password} onChange={(value)=>onChange('password',value)}/>
      <Input label="Confirm Password" value={values.confirmPassword} onChange={(value)=>onChange('confirmPassword',value)}/>
      <button type="submit">Register</button>
      <hr />
      <p>Already got an account, click here!</p>
    </form>
  );
};

export default Register;


