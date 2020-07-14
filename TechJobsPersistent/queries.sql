--Part 1
SHOW COLUMNS FROM jobs;

--Part 2
SELECT Name
FROM employers
WHERE location = "St. Louis City";
--Part 3

SELECT skills.Name, skills.Description from skills, jobs, jobskills
WHERE jobs.Id = jobskills.JobId and jobskills.SkillId = skills.Id
AND jobskills.jobId IS NOT NULL;
