insert into job ( job_type_id, 
				 title, 
				 description, 
				 date_posted,
				 date_expires, 
				 is_filled, 
				 client_id, 
				 salary_to,
				 salary_from, 
				 tags, 
				 job_role_id, 
				 is_spotlight, 
				 filter_candidate
				) values (
				 2,
				'Content Writer',
				'A growing digital marketing agency is in need of passionate individuals to 
				  join our team as a Content Writer',
				current_date,
					current_date + 30,
				  false,
					1, 
					500,
					300,
					'content writer, writer'
					, 5
					,true,
					true);

select * from job

 