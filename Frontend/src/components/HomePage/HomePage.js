import React from "react";
import HomeNav from "./HomeNav";
import logo from "../../assets/QuizLogo.png";
import FriendCard from "./FriendCard";

const HomePage = () => {
  return (
    <>
      <HomeNav />
      <div className="bg-sky-400 h-screen w-screen grid grid-cols-5">
        <div className="col-span-2">
          <a
            href="/Login"
            className="my-40 mx-auto flex flex-col items-center bg-white border border-gray-200 rounded-lg shadow md:flex-col md:max-w-xl hover:bg-gray-100 dark:border-gray-700 dark:bg-sky-400 dark:hover:bg-sky-700"
          >
            {/* <img
              className="object-cover w-full rounded-t-lg h-96 md:h-auto md:w-48 md:rounded-none md:rounded-s-lg"
              src="/docs/images/blog/image-4.jpg"
              alt=""
            /> */}
            <div className="flex flex-col justify-between p-4 leading-normal">
              <h5 className="mb-2 text-2xl font-bold tracking-tight text-gray-900 dark:text-white">
                vTrivia : Quiz App 2k24
              </h5>
              <p className="mb-3 font-normal text-gray-800 dark:text-gray-900">
                Welcome to vTrivia, where the thrill of trivia meets the joy of
                learning! Explore a wide range of categories, challenge friends
                in real-time multiplayer quizzes, and customize your own
                brain-teasers. With a sleek design and regular updates, vTrivia
                is the ultimate destination for quiz enthusiasts. Prove your
                knowledge, earn badges, and enjoy a fun and engaging experience.
                Get ready to be a Trivian!
              </p>
            </div>
          </a>
        </div>
        <div className="w-screen h-screen col-span-3 flex">
          <img
            src={logo}
            alt="quiz-app-logo"
            style={{ maxWidth: "100%", maxHeight: "100%" }}
          />
        </div>
      </div>
      <div className="grid grid-cols-4">
        <FriendCard
          friendName="Deepti"
          Role="Business Analyst"
          Github="abc"
          Linkedin="abc"
          className="col-span-1"
        />
        <FriendCard
          friendName="Aryan"
          Role="Frontend Engineer"
          Github="https://github.com/Aryan-Sanghi-008"
          Linkedin="https://www.linkedin.com/in/aryansanghi008/"
          className="col-span-1"
        />
        <FriendCard
          friendName="Dhruv Mathur"
          Role="Backend Engineer (.NET)"
          Github="abc"
          Linkedin="abc"
          className="col-span-1"
        />
        <FriendCard
          friendName="Amit Raheja"
          Role="Backend Engineer (.NET)"
          Github="abc"
          Linkedin="abc"
          className="col-span-1"
        />
      </div>
    </>
  );
};

export default HomePage;
