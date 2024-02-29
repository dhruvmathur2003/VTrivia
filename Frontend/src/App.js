import "./App.css";
import LoginPage from "./components/login-page/LoginPage";
import SignUpPage from "./components/SignUpPage/SignUpPage";
import ForgetPassword from "./components/ForgetPassword/ForgetPassword";
import ResetPassword from './components/ForgetPassword/ResetPassword'
import HomePage from "./components/HomePage/HomePage";
import { BrowserRouter, Routes, Route } from "react-router-dom";
// import {Toaster} from 'react-hot-toast';

function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="Login" element={<LoginPage />} />
          <Route path="SignUp" element={<SignUpPage />} />
          <Route path="ForgetPassword" element={<ForgetPassword />} />
          <Route path="ResetPassword" element={<ResetPassword/>}/>
        </Routes>
      </BrowserRouter>
    </>
  );
}


export default App;
