import React, { useState } from "react";
import Navbar from "../Navbar/Navbar";
import axios from "axios";
import { useNavigate } from "react-router-dom";
// import toast from "react-hot-toast";

const ResetPassword = ({ email }) => {
  const navigate = useNavigate();
  const [newPassword, setNewPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const handleSubmit = (event) => {
    event.preventDefault();
    if (newPassword === confirmPassword) {
      axios
        .post(
          "https://localhost:7089/resetPassword",
          {
            email,
            newPassword,
          },
          {
            headers: {
              "Content-Type": "application/json",
            },
          }
        )
        .then((response) => {
          console.log(response);
          alert("Your password has been changed");
          navigate("/Login");
        })
        .catch((error) => {
          console.log(error);
        });
    } else {
      toast.error('passwords did not match');
      navigate('/HomePage');
    }
  };
  return (
    <>
      <Navbar />
      <div className="h-screen bg-sky-300 flex justify-center items-center w-full">
        <form onSubmit={handleSubmit}>
          <div className="bg-blue-500 px-10 py-8 rounded-xl w-screen shadow-md max-w-sm">
            <div className="space-y-4">
              <h1 className="text-center text-2xl font-semibold text-white">
                Forget Password
              </h1>
              <div>
                <label
                  for="password"
                  className="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                >
                  New Password
                </label>
                <input
                  type="password"
                  name="password"
                  id="password"
                  placeholder="••••••••"
                  className="bg-gray-50 border border-gray-300 text-gray-900 sm:text-sm rounded-lg focus:ring-primary-600 focus:border-primary-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  required=""
                  onChange={(e) => setNewPassword(e.target.value)}
                />
              </div>
              <div>
                <label
                  for="password"
                  className="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                >
                  Confirm Password
                </label>
                <input
                  type="password"
                  name="password"
                  id="password"
                  placeholder="••••••••"
                  className="bg-gray-50 border border-gray-300 text-gray-900 sm:text-sm rounded-lg focus:ring-primary-600 focus:border-primary-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  required=""
                  onChange={(e) => setConfirmPassword(e.target.value)}
                />
              </div>
            </div>
            <button type="submit" className="mt-5 w-full bg-gradient-to-tr from-blue-600 to-indigo-600 text-indigo-100 py-2 rounded-md text-lg tracking-wide">
              Reset Password
            </button>
          </div>
        </form>
      </div>
    </>
  );
};

export default ResetPassword;
